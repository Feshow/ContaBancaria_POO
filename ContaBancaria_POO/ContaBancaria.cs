using System.Globalization;

namespace ProjetoContaBancaria
{
    // Criar a classe
    // Utilizar AutoProperties para criar restrições de alteração no Nº Conta e Saldo (Somente saque e depósito)
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        // Construtores (Utilizando sobrecarga e THIS)
        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = 0;
        }
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        //Método de Deposito e Saque (métodos)

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
