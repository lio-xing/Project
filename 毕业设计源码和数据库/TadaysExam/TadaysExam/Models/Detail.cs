//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TadaysExam.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detail
    {
        public int DetailID { get; set; }
        public int AnswerID { get; set; }
        public int TopicID { get; set; }
        public string DetailAnswer { get; set; }
    
        public virtual Asnwer Asnwer { get; set; }
        public virtual Topic Topic { get; set; }
    }
}
