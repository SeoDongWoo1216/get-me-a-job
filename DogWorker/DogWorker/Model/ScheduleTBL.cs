//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DogWorker.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ScheduleTBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ScheduleTBL()
        {
            this.DiaryTBL = new HashSet<DiaryTBL>();
        }
    
        public int Schidx { get; set; }
        public int Uidx { get; set; }
        public System.DateTime Schdate { get; set; }
        public System.TimeSpan Schtime { get; set; }
        public string Schplace { get; set; }
        public string Rsyn { get; set; }
        public System.DateTime Rstime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiaryTBL> DiaryTBL { get; set; }
        public virtual USERTBL USERTBL { get; set; }
    }
}
