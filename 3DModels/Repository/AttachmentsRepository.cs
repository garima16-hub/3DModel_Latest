using _3DModels.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace _3DModels.Repository
{
    public class AttachmentsRepository : IAttachments
    {
        private readonly ModelDbContext _dbContext;

        public AttachmentsRepository(ModelDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Attachments> GetAllAccessories()
        {
            return _dbContext.Attachment.ToList();
        }

        public Attachments GetAccessoriesById(int id)
        {
            return _dbContext.Attachment.FirstOrDefault(p => p.product_id == id);
        }

        public string CreateAccessories(Attachments attachment)
        {
            _dbContext.Attachment.Add(attachment);
            _dbContext.SaveChanges();
            return "Attachment created successfully.";
        }

        public string UpdateAccessories(Attachments attachment)
        {
            _dbContext.Attachment.Update(attachment);
            _dbContext.SaveChanges();
            return " Attachment updated successfully.";
        }

        public string DeleteAccessoriesById(int id)
        {
            var attachment = _dbContext.Attachment.Find(id);
            if (attachment == null)
            {
                return "Attachment not found.";
            }

            _dbContext.Attachment.Remove(attachment);
            _dbContext.SaveChanges();
            return "Attachment deleted successfully.";
        }
    }
}
