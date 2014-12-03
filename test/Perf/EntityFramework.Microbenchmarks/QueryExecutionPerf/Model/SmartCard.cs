// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EntityFramework.Microbenchmarks.QueryExecutionPerf.Model;

namespace EntityFramework.Microbenchmarks.QueryExecutionPerf.Model
{
    [Table("DefaultContainerStore.SmartCard")]
    public class SmartCard
    {
        [Key]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        public string CardSerial { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Issued { get; set; }

        [StringLength(50)]
        public string SmartcardUsername { get; set; }

        public virtual LastLogin LastLogin { get; set; }

        public virtual Login Login { get; set; }
    }
}
