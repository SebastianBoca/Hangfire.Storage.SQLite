﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hangfire.Storage.SQLite.Entities
{
    public class State
    {
        private string _statePK = string.Empty;
        
        [PrimaryKey]
        public string StatePK { 
            get => Id + "_" + JobId;
            set => _statePK = value;
        }

        //[AutoIncrement]
        [Indexed(Name = "IX_State_Id", Order = 1, Unique = false)]
        public int Id { get; set; }

        [Indexed(Name = "IX_State_JobId", Order = 2, Unique = false)]
        public int JobId { get; set; }

        [MaxLength(DefaultValues.MaxLengthStateNameColumn)]
        public string Name { get; set; }

        [MaxLength(DefaultValues.MaxLengthReasonColumn)]
        public string Reason { get; set; }

        public DateTime CreatedAt { get; set; }

        [MaxLength(DefaultValues.MaxLengthVarCharColumn)]
        public string Data { get; set; }
    }
}