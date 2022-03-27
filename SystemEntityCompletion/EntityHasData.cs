using Entity4.SystemEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Entity4.SystemEntityCompletion
{
    public static class EntityHasData
    {
        public static async Task SetCompletionData()
        {
            using (ApplicationContext application = new ApplicationContext())
            {

                Country country = new Country { Names = "Russia" };
                Country country1 = new Country { Names = "China" };

                Pol pol = new Pol { Name = "Мужчина" };
                Pol pol1 = new Pol { Name = "Женчина" };

                Groups Groups = new Groups { Name = "Группа 1" };
                Groups Groups1 = new Groups { Name = "Группа 2" };

                Role role = new Role { Name = "Админ" };
                Role role1 = new Role { Name = "Пользователь" };

                User user = new User { Name = "Petja1@bk.ru", Country = country };
                User user1 = new User { Name = "Petja2@bk.ru", Country = country };
                User user2 = new User { Name = "Petja3@bk.ru", Country = country1 };
                User user3 = new User { Name = "Petja4@bk.ru", Country = country1 };

                Profile profile = new Profile { Name = "petja1", User = user, Pol = pol };
                Profile profile1 = new Profile { Name = "petja2", User = user1, Pol = pol };
                Profile profile2 = new Profile { Name = "petja3", User = user2, Pol = pol1 };
                Profile profile3 = new Profile { Name = "petja4", User = user3, Pol = pol1 };

                /*Theme theme1 = new Theme { Name = "Тема 1"};
                Theme theme2 = new Theme { Name = "Тема 2" };
                Theme theme3 = new Theme { Name = "Тема 3" };
                Theme theme4 = new Theme { Name = "Тема 4" };
                Theme theme5 = new Theme { Name = "Тема 5" };
                Theme theme6 = new Theme { Name = "Тема 6" };

                Message message1 = new Message { Theme = theme1, MessageText = "Сообщение 1", DateCreate = DateTime.Now.ToString() };
                Message message2 = new Message { Theme = theme2, MessageText = "Сообщение 2", DateCreate = DateTime.Now.ToString() };
                Message message3 = new Message { Theme = theme3, MessageText = "Сообщение 3", DateCreate = DateTime.Now.ToString() };
                Message message4 = new Message { Theme = theme4, MessageText = "Сообщение 4", DateCreate = DateTime.Now.ToString() };
                Message message5 = new Message { Theme = theme5, MessageText = "Сообщение 5", DateCreate = DateTime.Now.ToString() };
                Message message6 = new Message { Theme = theme6, MessageText = "Сообщение 6", DateCreate = DateTime.Now.ToString() };

                AddresSent addresSent1 = new AddresSent { Message = message1, SenderId = 1, RecipientId = 2, DateCreate = DateTime.Now.ToString() };
                AddresSent addresSent2 = new AddresSent { Message = message2, SenderId = 1, RecipientId = 2, DateCreate = DateTime.Now.ToString() };
                AddresSent addresSent3 = new AddresSent { Message = message3, SenderId = 1, RecipientId = 2, DateCreate = DateTime.Now.ToString() };
                AddresSent addresSent4 = new AddresSent { Message = message4, SenderId = 1, RecipientId = 2, DateCreate = DateTime.Now.ToString() };
                AddresSent addresSent5 = new AddresSent { Message = message5, SenderId = 1, RecipientId = 2, DateCreate = DateTime.Now.ToString() };
                AddresSent addresSent6 = new AddresSent { Message = message6, SenderId = 1, RecipientId = 2, DateCreate = DateTime.Now.ToString() };*/

                /*user.GroupsIntermediates.Add(new GroupsIntermediate { Groups = Groups1 });
                user1.GroupsIntermediates.Add(new GroupsIntermediate { Groups = Groups1 });
                user2.GroupsIntermediates.Add(new GroupsIntermediate { Groups = Groups1 });
                user3.GroupsIntermediates.Add(new GroupsIntermediate { Groups = Groups1 });

                user.GroupsIntermediates.Add(new GroupsIntermediate { Groups = Groups });
                user1.GroupsIntermediates.Add(new GroupsIntermediate { Groups = Groups });
                user2.GroupsIntermediates.Add(new GroupsIntermediate { Groups = Groups });
                user3.GroupsIntermediates.Add(new GroupsIntermediate { Groups = Groups });

                user.RoleIntermediates.Add(new RoleIntermediate { Role = role });
                user1.RoleIntermediates.Add(new RoleIntermediate { Role = role1 });
                user2.RoleIntermediates.Add(new RoleIntermediate { Role = role1 });
                user3.RoleIntermediates.Add(new RoleIntermediate { Role = role1 });

                application.Countrys.AddRange(country, country1);

                application.Groups.AddRange(Groups, Groups1);

                application.Pols.AddRange(pol, pol1);

                application.Users.AddRange(user, user1, user2, user3);

                application.Profiles.AddRange(profile, profile1, profile2, profile3);*/

                /*application.Themes.AddRange(theme1, theme2, theme3, theme4, theme5, theme6);

                application.Messages.AddRange(message1, message2, message3, message4, message5, message6);

                application.AddresSents.AddRange(addresSent1, addresSent2, addresSent3, addresSent4, addresSent5, addresSent6);*/

                await application.SaveChangesAsync();
            }
        }
    }
}
