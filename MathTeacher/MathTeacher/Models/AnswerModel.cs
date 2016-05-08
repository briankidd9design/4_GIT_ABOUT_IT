﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elena_Test.Models
{
    public class AnswerModel
    {
        public int AnswerID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTIme {get; set;}

        public virtual ICollection<GameModel> Game { get; set; }
        public virtual ICollection<QuestionModel> Question { get; set; }

    }
}
