using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rc.Models
{
    public class Revenue
    {
        public int RevenueID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "年份")]
        public string Column_A { get; set; }
        //[Required]
        //[NotMapped]
        [StringLength(50)]
        [Display(Name = "序号")]
        public string Column_B { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "营销单位")]
        public string Column_C { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "国际/国内")]
        public string Column_D { get; set; }
        [Required]

        [Display(Name = "贡献收入预算")]
        public double Column_E { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "代理人名称")]
        public string Column_F { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "是否有协议")]
        public string Column_G { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "协议名称")]
        public string Column_H { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "协议编号")]
        public string Column_I { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "协议起始时间")]
        public DateTime Column_J { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "协议终止时间")]
        public DateTime Column_K { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "协议对方简称")]
        public string Column_L { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "协议全周期标的额/量")]
        public string Column_M { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "协议考核额/量")]
        public string Column_N { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "实际完成")]
        public string Column_O { get; set; }
        [Required]

        [Display(Name = "协议完成比例")]
        public double Column_P { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "未完成协议情况说明")]
        public string Column_Q { get; set; }
        [Required]

        [Display(Name = "协议/散销收入金额")]
        public double Column_R { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "公司分管领导")]
        public string Column_S { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "业务类别")]
        public string Column_T { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "主办部门承办人")]
        public string Column_U { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "主办部门领导")]
        public string Column_V { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "会签部门")]
        public string Column_W { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "法律部门意见")]
        public string Column_X { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "协议签署依据")]
        public string Column_Y { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "审批人")]
        public string Column_Z { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "协议签署人")]
        public string Column_AA { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "协议变更说明")]
        public string Column_AB { get; set; }
        //[Required]
        [StringLength(50)]
        [Display(Name = "备注")]
        public string Column_AC { get; set; }

    }
}