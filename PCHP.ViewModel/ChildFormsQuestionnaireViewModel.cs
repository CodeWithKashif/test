using System;

namespace PCHP.ViewModel
{
    public class ChildFormsQuestionnaireViewModel
    {
        public int Id { get; set; }

        public int ChildCoreFormsDetailId { get; set; }
        public int QuestonId { get; set; }
        public int AnswerId { get; set; }

        public int IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedOn { get; set; }
    }
}
