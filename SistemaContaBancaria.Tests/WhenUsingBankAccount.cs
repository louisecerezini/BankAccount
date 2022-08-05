using SistemaContaBancaria.Entities;

namespace SistemaContaBancaria.Tests
{
    
    public class WhenUsingBankAccount
    {
        [Fact]
        // criar uma conta com nome valido e validando se a conta foi criada 
        public void Client_CreateAccountWithValidName_ReturnsAccount()
        {
            var account = new BankAccount("Bolt");
            Assert.NotNull(account);
        }

        // criando uma conta sem passar nome, deve retornar um erro 
        [Fact]
        public void Client_CreateAccountWithInvalidName_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new BankAccount(""));
        }

        // adicionando saldo para a conta valida se o saldo da conta é atualizado
        [Fact]
        public void Client_AddCreditToAccount_AccountBalanceIsUpdated()
        {
            
            double creditToBeAdded = 450.00;
            double creditToBeAdded2 = 250.00;
            double expectedBalance = 700.00;

            var account = new BankAccount("Bolt");

            
            account.Credit(creditToBeAdded);
            account.Credit(creditToBeAdded2);

            
            Assert.Equal(expectedBalance, account.CheckBalance());
        }

        // sacando da conta e obtendo o saldo final 
        [Fact]
        public void Client_DebitfromAccount_AccountBalanceIsUpdated()
        {
            double initialBalance = 1000.00;
            double debit1 = 450.00;
            double debit2 = 250.00;
            double expectedBalance = 300.00;

            var account = new BankAccount("Bolt");

            account.Credit(initialBalance);
            account.Debit(debit1);
            account.Debit(debit2);

            Assert.Equal(expectedBalance, account.CheckBalance());
        }
    }
}