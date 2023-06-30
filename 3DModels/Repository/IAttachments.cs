using _3DModels.Models;
using System.Collections.Generic;

namespace _3DModels.Repository
{
    public interface IAttachments
    {
        List<Attachments> GetAllAccessories();
        Attachments GetAccessoriesById(int id);
        string CreateAccessories(Attachments attachment);
        string UpdateAccessories(Attachments attachment);
        string DeleteAccessoriesById(int id);
    }
}
