﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Banking {
    class Account {
        public string AccountNumber { get; set; }
        public string RoutingNumber { get; set; }
        public string Description { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount) {
            if (amount >= 0) {
                Balance += amount;
            }
        }
        public void Withdrawal(decimal amount) {
            if (amount <0) {
                return;
            }
            if (Balance >= amount) {
                Balance -= amount;
            }















        }   } }
    

















