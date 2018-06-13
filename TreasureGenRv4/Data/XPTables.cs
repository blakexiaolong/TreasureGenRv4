﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace TreasureGenRv4.Data
{
    internal static class XpTables
    {
        public static Dictionary<decimal, int> GetCrValue() =>
            JsonConvert.DeserializeObject<Dictionary<decimal, int>>(@"{
                '0.125': '50',
                '0.25': '100',
                '0.5': '200',
                '1': '400',
                '2': '600',
                '3': '800',
                '4': '1200',
                '5': '1600',
                '6': '2400',
                '7': '3200',
                '8': '4800',
                '9': '6400',
                '10': '9600',
                '11': '12800',
                '12': '19200',
                '13': '25600',
                '14': '38400',
                '15': '51200',
                '16': '76800',
                '17': '102400',
                '18': '153600',
                '19': '204800',
                '20': '307200',
                '21': '409600',
                '22': '614400',
                '23': '819200',
                '24': '1228800',
                '25': '1638400'
            }");

        public static Dictionary<int, int[]> GetValuePerEncounter() =>
            JsonConvert.DeserializeObject<Dictionary<int, int[]>>(@"{
                '1': ['170', '260', '400'],
                '2': ['350', '550', '800'],
                '3': ['550', '800', '1200'],
                '4': ['750', '1150', '1700'],
                '5': ['1000', '1550', '2300'],
                '6': ['1350', '2000', '3000'],
                '7': ['1750', '2600', '3900'],
                '8': ['2200', '3350', '5000'],
                '9': ['2850', '4250', '6400'],
                '10': ['3650', '5450', '8200'],
                '11': ['4650', '7000', '10500'],
                '12': ['6000', '9000', '13500'],
                '13': ['7750', '11600', '17500'],
                '14': ['10000', '15000', '22000'],
                '15': ['13000', '19500', '29000'],
                '16': ['16500', '25000', '38000'],
                '17': ['22000', '32000', '48000'],
                '18': ['28000', '41000', '62000'],
                '19': ['35000', '53000', '79000'],
                '20': ['44000', '67000', '100000']
            }");

        public static Dictionary<int, int> GetNpcValue() =>
            JsonConvert.DeserializeObject<Dictionary<int, int>>(@"{
               '1': '260',
               '2': '390',
               '3': '780',
               '4': '1650',
               '5': '2400',
               '6': '3450',
               '7': '4650',
               '8': '6000',
               '9': '7800',
               '10': '10050',
               '11': '12750',
               '12': '16350',
               '13': '21000',
               '14': '27000',
               '15': '34800',
               '16': '45000',
               '17': '58500',
               '18': '75000',
               '19': '96000',
               '20': '123000',
               '21': '159000'
            }");
    }
}