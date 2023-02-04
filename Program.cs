namespace AtividadeEncontroRemoto02BackEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Endereco Endereco = new Endereco();

            Endereco.TipoEndereco = (int)TipoEndereco.Residencial;
            Endereco.CFP = "42713850";
            Endereco.Logradouro = "Travessa Costa";
            Endereco.Numero = "69";
            Endereco.Complemento = "Casa";
            Endereco.Bairro = "Portão";
            Endereco.Cidade = "Lauro de Freitas";
            Endereco.UF = "BA";

            PessoaFisica PF = new PessoaFisica();

            PF.Nome = "Robson Junior";
            PF.Endereco = Endereco;
            PF.IdPessoalFisica = null;
            PF.CPF = "0000000000";
            PF.DataNascimento = new DateTime(1996-04-04);

            PessoaJuridica PJ = new PessoaJuridica();

            PJ.Nome = "Islana Silva";
            PJ.Endereco = Endereco;
            PJ.IdPessoaJuridica = null;
            PJ.CNPJ = "00000000000001";
            PJ.RazaoSocial = "Nome da Empresa";

            var validarDataNascimento = PF.VerificarDataNascimento(PF.DataNascimento);

            if (validarDataNascimento) {
                Console.WriteLine("ok");
            }

            if (PJ.ValidarCNPJ(PJ.CNPJ)) {
                Console.WriteLine("CNPJ Válido");
            } else {
                Console.WriteLine("CNPJ Inválido");
            }

        }
    }
}
