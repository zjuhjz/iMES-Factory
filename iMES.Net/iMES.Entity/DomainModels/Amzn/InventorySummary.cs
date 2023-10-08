/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果数据库字段发生变化，请在代码生器重新生成此Model
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iMES.Entity.SystemModels;

namespace iMES.Entity.DomainModels
{
    [Entity(TableCnName = "亚马逊ID查询", TableName = "amzv2.inventory_summary", DBServer = "SysDbContext")]
    [Table("amzv2.inventory_summary")]
    public partial class InventorySummary : SysEntity
    {
        /// <summary>
        ///asin
        /// </summary>
        [Display(Name = "asin")]
        [MaxLength(10)]
        [Column(TypeName = "nvarchar(10)")]
        [Editable(true)]
        public string asin { get; set; }

        /// <summary>
        ///sellerSku
        /// </summary>
        [Key]
        [Display(Name = "sellerSku")]
        [MaxLength(20)]
        [Column(TypeName = "varchar(20)")]
        [Editable(true)]
        [Required(AllowEmptyStrings = false)]
        public string sellerSku { get; set; }

        /// <summary>
        ///fnSku
        /// </summary>
        [Display(Name = "fnSku")]
        [MaxLength(10)]
        [Column(TypeName = "nvarchar(10)")]
        [Editable(true)]
        public string fnSku { get; set; }

        /// <summary>
        ///productName
        /// </summary>
        [Display(Name = "productName")]
        [MaxLength(300)]
        [Column(TypeName = "nvarchar(300)")]
        [Editable(true)]
        public string productName { get; set; }

        /// <summary>
        ///branchId
        /// </summary>
        [Display(Name = "branchId")]
        [Column(TypeName = "int")]
        [Editable(true)]
        public int? branchId { get; set; }
    }
}