﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class QuestCompletionItem
    {
        public Item Details { get; set; }
        public int Quatity { get; set; }

        public QuestCompletionItem(Item details, int quantity)
        {
            Details = details;
            Quatity = quantity;
        }
    }
}
