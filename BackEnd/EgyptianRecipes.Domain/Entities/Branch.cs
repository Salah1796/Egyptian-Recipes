using EgyptianRecipes.Domain.Common;
using EgyptianRecipes.Domain.Common.Contracts;
using System;
using System.Collections.Generic;

namespace EgyptianRecipes.Domain.Entities
{
    public class Branch : IEntityIdentity<Guid>, IDeletionSignature, IEntityCreatedUserSignature,
        IEntityModifiedUserSignature, IModificatioDateSignature , ICreationDateSignature
    {
        #region IEntityIdentity
        public Guid Id { get; set; }
        #endregion

        #region IDeletionSignature
        public bool IsDeleted { get; set; }
        public DateTime? DeletionDate { get; set; }
        public Guid? DeletedByUserId { get; set; }
        public bool? MustDeletedPhysical { get; set; }
        #endregion

        #region IEntityCreatedUserSignature
        public Guid CreatedByUserId { get; set; }
        #endregion
        #region ICreationDateSignature 
        public DateTime CreationDate { get; set; }
        #endregion

        #region IEntityModifiedUserSignature
        public Guid? FirstModifiedByUserId { get; set; }
        public Guid? LastModifiedByUserId { get; set; }
        #endregion
        #region IModificatioDateSignature
        public DateTime? FirstModificationDate { get; set; }
        public DateTime? LastModificationDate { get; set; }
        #endregion

        public string Title { get; set; }
        public DateTime OpeningHour { get; set; }
        public DateTime ClosingHour { get; set; }
        public string ManagerName  { get; set; }
    }
}
