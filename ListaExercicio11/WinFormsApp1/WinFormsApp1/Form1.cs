namespace WinFormsApp1
{
    public partial class Form_principal : Form
    {

        List<String> listaNomes = new List<String>();

        public Form_principal()
        {
            InitializeComponent();
        }

        private void button_adicionarLista_Click(object sender, EventArgs e)
        {
            inserirTextBox_lista();
        }

        private void textBox_nomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char) Keys.Enter)
            {
                inserirTextBox_lista();
            }
        }

        private void inserirTextBox_lista()
        {
            if (textBox_nomeCompleto.Text == "")
            {
                MessageBox.Show("Digite algo", "ATENCAO");
            }
            else
            {
                if (listaNomes.Contains(textBox_nomeCompleto.Text.ToUpper()))
                {
                    MessageBox.Show("nome ja cadastrado", "atencao");
                    textBox_nomeCompleto.Text = String.Empty;
                }
                else
                {
                    listaNomes.Add(textBox_nomeCompleto.Text.ToUpper());
                    listaNomes.Sort();

                    atualizarTextBoxLista();
                    textBox_nomeCompleto.Text = String.Empty;
                }
            }
            textBox_nomeCompleto.Focus();
        }
        private void atualizarTextBoxLista()
        {
            textBox_listaNomes.Text = String.Empty;
            foreach(var i in listaNomes)
            {
                textBox_listaNomes.Text += i + Environment.NewLine;
            }
        }



    }
}