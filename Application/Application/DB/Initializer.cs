using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Application.DB
{
    public class Initializer : CreateDatabaseIfNotExists<DBModel>
    {
        protected override void Seed(DBModel context)
        {
            // Создание объекта в памяти
            User user = new User()
            {
                Name = "Иванов Иван Иванович",
                Login = "Ivan",
                Password = "1234567",
                IDCompany=1,
                StatusContract="Заключен"
            };
            Company company = new Company()
            {
                Name = "IBM"
                
            };
            // Добавление объекта в таблицу
            context.User.Add(user);
            context.Company.Add(company);
            //// Сохранить данные в БД
            context.SaveChanges();
        }
    }
}