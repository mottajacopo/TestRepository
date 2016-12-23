﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_08
{
    public class QuoteRepository
    {
        public IEnumerable<Quote> GetAllQuotes()
        {
            return new List<Quote>()
        {
            new Quote(){Symbol = "IBM", Price= 1}
            , new Quote() {Symbol = "IBM", Price = 1.2m}
            , new Quote() {Symbol = "IBM", Price = 1.3m}
            , new Quote() {Symbol = "DELL", Price = 2.1m}
            , new Quote() {Symbol = "IBM", Price = 3.2m}
            , new Quote() {Symbol = "DELL", Price = 2.9m}
            , new Quote() {Symbol = "IBM", Price = 1.8m}
            , new Quote() {Symbol = "DELL", Price = 1.7m}
        };
        }
    }
}
