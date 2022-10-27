namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        List<Pessoa> listaPessoa = new List<Pessoa>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_inserirLista_Click(object sender, EventArgs e)
        {
            if(textBox_nome.Text.Length == 0 || textBox_email.Text.Length == 0)
            {
                MessageBox.Show("Precisa digitar nos dois campos", "ATENCAO");
            }
            else
            {
                if(listaPessoa.Exists(pessoa => pessoa.Email == textBox_email.Text))
                {
                    MessageBox.Show("Email ja cadastrado, digite email diferente", "ATENCAO");
                }
                else
                {
                    Pessoa pessoa = new Pessoa(textBox_nome.Text, textBox_email.Text);
                    listaPessoa.Add(pessoa);
                    limparCampos();
                }
            }
        }

        private void limparCampos()
        {
            textBox_nome.Clear();
            textBox_email.Clear();
        }

        private void atualizaListas()
        {
            atualizaListaNome();
            atualizaListaEmail();
            atualizaListaDominios();
        }

        private void atualizaListaNome()
        {
            textBox_listaNomes.Text = String.Empty;

            foreach(var i in listaPessoa)
            {
                textBox_listaNomes.Text += i.Nome + Environment.NewLine;
            }
        }

        private void atualizaListaEmail()
        {
            textBox_listaEmails.Text = String.Empty;

            foreach (var i in listaPessoa)
            {
                textBox_listaEmails.Text += i.Email + Environment.NewLine;
            }
        }

        private void atualizaListaDominios()
        {
            foreach(var i in listaPessoa)
            {
                string[] dados = i.Email.Split("@");
                textBox_listaDominios.Text += dados[1] + Environment.NewLine;
            }
        }

        private void button_listar_Click(object sender, EventArgs e)
        {
            atualizaListas();
        }

        private void button_limpa_Click(object sender, EventArgs e)
        {
            textBox_listaEmails.Clear();
            textBox_listaNomes.Clear();
            textBox_listaDominios.Clear();
        }
    }
}