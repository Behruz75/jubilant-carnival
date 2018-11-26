// Jubliant Carnaval 
// Prototype
// English Version
// Fecit: Akramov Behruz

using System.Windows.Forms;
using Microsoft.VisualBasic;

class JubliantCarnaval
{
    static void Main()
    {
        string name, password;
        name = Interaction.InputBox(
            "Enter name: ",
            "Name");
        password = Interaction.InputBox(
            "Enter password: ",
            "Password");
        if (name == "Behruz" && password == "Akramov75")
        {
            MessageBox.Show("You have successfully entered\nPress 'OK' to get the key",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            MessageBox.Show("Key: XXXX-YYYY-ZZZZ-PPPP\nYou need to write down this key!",
                "Key",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("You enter invalid name or password!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}