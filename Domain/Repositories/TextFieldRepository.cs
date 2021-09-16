using NewWebShopStream.Domain.Intefaces;
using NewWebShopStream.Domain.Models;
using NewWebShopStream.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebShopStream.Domain.Repositories
{
    public class TextFieldRepository : ITextFieldRepository
    {
        private readonly AppDbContext db;
        public TextFieldRepository(AppDbContext appDbContext)
        {
            db = appDbContext;
        }
        public void DeleteTextField(Guid id)
        {
            var textField = db.TextFields.FirstOrDefault(t => t.Id.Equals(id));
            if (textField != null)
            {
                db.TextFields.Remove(textField);
                ///db.Entry<TextField>(textField).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public TextField GetTextFieldByCodeWord(string codeWord)
        {
            return db.TextFields.FirstOrDefault(t => t.CodeWord == codeWord);
        }

        public TextField GetTextFieldById(Guid id)
        {
            return db.TextFields.Find(id);
        }

        public IQueryable<TextField> GetTextFields()
        {
            return db.TextFields;
        }

        public void SaveTextField(TextField textField)
        {
            if (textField.Id == default)
                db.Entry<TextField>(textField).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            else
                db.Entry<TextField>(textField).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
