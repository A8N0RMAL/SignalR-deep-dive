using Microsoft.AspNetCore.SignalR.Client;
namespace ChatApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        HubConnection connection;
        private void Form1_Load(object sender, EventArgs e)
        {
            // define connection to the SignalR hub
            connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7253/chat")
                .Build();

            // start the connection
            connection.StartAsync();

            // define callback functions for receiving messages
            // 1. newMessage
            // deserialze JSON data to C# object
            connection.On<string, string>("newMessage", (name, message) =>
            {
                var newMessage = $"{name}: {message}";
                lb_messages.Invoke(new Action( () => lb_messages.Items.Add(newMessage))); // thread-safe UI update using Invoke Action delegate.
            }); 

            // 2. newMember
            connection.On<string, string>("newMember", (name, groupName) =>
            {
                var newMessage = $"{name} has joined the group {groupName}.";
                lb_messages.Items.Add(newMessage);
            });

            // 3. newGroupMessage
            connection.On<string, string, string>("newGroupMessage", (groupName, name, message) =>
            {
                var newMessage = $"[{groupName}] : {name} : {message}";
                lb_messages.Items.Add(newMessage);
            });

            // 4. controllerMessage
            connection.On<string>("controllerMessage", (message) =>
            {
                var newMessage = $"[Controller] : {message}";
                lb_messages.Invoke(new Action(() => lb_messages.Items.Add(newMessage)));
            });
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            connection.InvokeAsync("sendMessage", txt_name.Text, txt_message.Text);
        }
    }
}
