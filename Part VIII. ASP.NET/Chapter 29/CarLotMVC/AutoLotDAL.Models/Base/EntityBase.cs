﻿using System.ComponentModel.DataAnnotations;

namespace AutoLotDAL.Models.Base
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}