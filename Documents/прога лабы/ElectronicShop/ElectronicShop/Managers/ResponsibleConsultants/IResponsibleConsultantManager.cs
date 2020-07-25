
using ElectronicShop.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Managers.ResponsibleConsultants
{
    public interface IResponsibleConsultantManager
    {
        Task<ResponsibleConsultant> Delete(Guid id);
        Task<ResponsibleConsultant> AddToAsort(CreateOrUpdateResponsibleConsultantRequest tmp);
        Task<IReadOnlyCollection<ResponsibleConsultant>> Output();
        Task<ResponsibleConsultant> GetById(Guid id);
        Task<ResponsibleConsultant> Redact(Guid id, CreateOrUpdateResponsibleConsultantRequest tmp);
    }
}
