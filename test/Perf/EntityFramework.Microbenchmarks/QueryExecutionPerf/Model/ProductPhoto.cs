// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EntityFramework.Microbenchmarks.QueryExecutionPerf.Model;

namespace EntityFramework.Microbenchmarks.QueryExecutionPerf.Model
{
    [Table("DefaultContainerStore.ProductPhoto")]
    public class ProductPhoto
    {
        public ProductPhoto()
        {
            Features = new HashSet<ProductWebFeature>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhotoId { get; set; }

        [Required]
        [MaxLength(8000)]
        public byte[] Photo { get; set; }

        public virtual Product Product { get; set; }

        public virtual ICollection<ProductWebFeature> Features { get; set; }
    }
}
