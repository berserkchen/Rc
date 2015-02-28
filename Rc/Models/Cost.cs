using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rc.Models
{
    public class Cost
    {
        public int CostID { get; set; }
        
        [StringLength(50)]
        [Display(Name = "年份")]
        public String Column_A { get; set; }
        //
        //[NotMapped]
        [StringLength(50)]
        [Display(Name = "序号")]
        public String Column_B { get; set; }
        
        [StringLength(50)]
        [Display(Name = "主办部门（发起单位）")]
        public String Column_C { get; set; }
        
        [StringLength(50)]
        [Display(Name = "公司分管领导")]
        public String Column_D { get; set; }
        
        [StringLength(50)]
        [Display(Name = "预算项目名称")]
        public String Column_E { get; set; }
        
        [StringLength(50)]
        [Display(Name = "预算主管部门")]
        public String Column_F { get; set; }

        
        [Display(Name = "预算金额")]
        public double? Column_G { get; set; }
        
        [StringLength(50)]
        [Display(Name = "是否有合同")]
        public String Column_H { get; set; }
        
        [StringLength(50)]
        [Display(Name = "属性")]
        public String Column_I { get; set; }
        
        [StringLength(50)]
        [Display(Name = "采购/外包方式")]
        public String Column_J { get; set; }
        
        [StringLength(50)]
        [Display(Name = "采购/外包依据")]
        public String Column_K { get; set; }
        
        [StringLength(50)]
        [Display(Name = "业务类别")]
        public String Column_L { get; set; }
        
        [StringLength(50)]
        [Display(Name = "合同级别")]
        public String Column_M { get; set; }
        
        [StringLength(50)]
        [Display(Name = "主办部门承办人")]
        public String Column_N { get; set; }
        
        [StringLength(50)]
        [Display(Name = "主办部门领导")]
        public String Column_O { get; set; }
        
        [StringLength(50)]
        [Display(Name = "会签部门")]
        public String Column_P { get; set; }
        
        [StringLength(50)]
        [Display(Name = "法律部门意见")]
        public String Column_Q { get; set; }
        
        [StringLength(50)]
        [Display(Name = "审批部门/审批人")]
        public String Column_R { get; set; }
        
        [StringLength(50)]
        [Display(Name = "签署人")]
        public String Column_S { get; set; }
        
        [StringLength(50)]
        [Display(Name = "合同编号")]
        public String Column_T { get; set; }
        
        [StringLength(50)]
        [Display(Name = "合同名称")]
        public String Column_U { get; set; }
        
        [StringLength(50)]
        [Display(Name = "合同对方")]
        public String Column_V { get; set; }
        
        [StringLength(50)]
        [Display(Name = "合同主要内容")]
        public String Column_W { get; set; }
        
        [StringLength(50)]
        [Display(Name = "合同标的类型")]
        public String Column_X { get; set; }
        
        [StringLength(50)]
        [Display(Name = "合同全周期标的额")]
        public String Column_Y { get; set; }

        [StringLength(50)]
        [Display(Name = "合同签订日期")]
        public string Column_Z { get; set; }

        [StringLength(50)]
        [Display(Name = "合同生效日期")]
        public string Column_AA { get; set; }

        [StringLength(50)]
        [Display(Name = "合同约定的终止日期")]
        public string Column_AB { get; set; }
        
        [StringLength(50)]
        [Display(Name = "合同变更说明")]
        public String Column_AC { get; set; }
        
        
        [Display(Name = "实际支付金额")]
        public double? Column_AD { get; set; }
        
        [StringLength(50)]
        [Display(Name = "预算金额与实际支付金额差异说明")]
        public String Column_AE { get; set; }
        //
        [StringLength(50)]
        [Display(Name = "备注")]
        public String Column_AF { get; set; }

    }
}