//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class 예산
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 예산()
        {
            this.분기별예산 = new HashSet<분기별예산>();
        }
    
        public string 예산코드 { get; set; }
        public System.DateTime 신청연도 { get; set; }
        public string 예산과목명 { get; set; }
        public int 총액 { get; set; }
        public int C1분기_금액 { get; set; }
        public int C2분기_금액 { get; set; }
        public int C3분기_금액 { get; set; }
        public int C4분기_금액 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<분기별예산> 분기별예산 { get; set; }
    }
}
