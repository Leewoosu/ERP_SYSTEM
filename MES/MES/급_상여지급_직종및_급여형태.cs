//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MES
{
    using System;
    using System.Collections.Generic;
    
    public partial class 급_상여지급_직종및_급여형태
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 급_상여지급_직종및_급여형태()
        {
            this.급여형태 = new HashSet<급여형태>();
        }
    
        public int 급_상여지급_직종코드 { get; set; }
        public string 지급번호코드 { get; set; }
        public string 사업장명 { get; set; }
        public string 직종 { get; set; }
        public System.DateTime 상여지급대상기간_시작일 { get; set; }
        public System.DateTime 상여지급대상기간_종료일 { get; set; }
        public int 상여지급대상기간_일수 { get; set; }
    
        public virtual 급_상여지급_급여구분 급_상여지급_급여구분 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<급여형태> 급여형태 { get; set; }
    }
}
