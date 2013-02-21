﻿namespace SogetiDemo.TDD.BankApp.Common.Entities
{
    public class BankAccount
    {
        public static readonly BankAccount Empty = new BankAccount(0);
       
        public BankAccount(decimal balance)
        {
            Balance = balance;
        }

        /// <summary>
        /// Autogenerated by RavenDB
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The account name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The current balance
        /// </summary>
        public decimal Balance { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amountToDeposit"></param>
        public void Deposit(decimal amountToDeposit)
        {
            Balance += amountToDeposit;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amountToWithDraw"></param>
        public void WithDraw(decimal amountToWithDraw)
        {
            Balance -= amountToWithDraw;
        }
    }
}
