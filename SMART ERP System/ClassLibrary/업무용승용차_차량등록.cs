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
    
    public partial class 업무용승용차_차량등록
    {
        public string 업무용승용차코드번호 { get; set; }
        public string 차량번호 { get; set; }
        public string 차종 { get; set; }
        public Nullable<System.DateTime> 처분일자 { get; set; }
        public string 사용여부 { get; set; }
        public string 임차구분 { get; set; }
        public System.DateTime 임차기간시작일 { get; set; }
        public System.DateTime 임차기간종료일 { get; set; }
        public string 사용구분 { get; set; }
        public string 고정자산코드 { get; set; }
    
        public virtual 고정자산 고정자산 { get; set; }
    }
}
