using _3DModels.Models;
using _3DModels.Repository;
using System.Collections.Generic;

namespace _3DModels.Services
{
    public class AttachmentService
    {
        private readonly AttachmentsRepository _productRepo;

        public AttachmentService(AttachmentsRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public List<Attachments> GetAllAccessories()
        {
            return _productRepo.GetAllAccessories();
        }

        public Attachments GetAccessoriesById(int id)
        {
            return _productRepo.GetAccessoriesById(id);
        }

        public string CreateAccessories(Attachments attachment)
        {
            return _productRepo.CreateAccessories(attachment);
        }

        public string UpdateAccessories(Attachments attachment)
        {
            return _productRepo.UpdateAccessories(attachment);
        }

        public string DeleteAccessoriesById(int id)
        {
            return _productRepo.DeleteAccessoriesById(id);
        }
    }
}
