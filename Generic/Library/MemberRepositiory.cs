using Library.Data;
using Library.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositiories
{
    internal class MemberRepositiories
    {
        public GenericResponse<List<Member>> GetAllMembers()
        {
            var members = DataStorage.Members;
            return new GenericResponse<List<Member>>
            {
                Success = true,
                Data = members,
            };
        }

        public GenericResponse<Member> GetMemberById(int id)
        {
            var member = DataStorage.Members.FirstOrDefault(x => x.Id == id);
            if (member == null)
            {
                return new GenericResponse<Member>
                {
                    Success = false,
                    Message = "Member not found",
                };
            }

            return new GenericResponse<Member>
            {
                Success = true,
                Data = member,
            };
        }

        public GenericResponse<List<Member>> SearchMemberByName(string name)
        {
            var members = DataStorage.Members
                .Where(b => b.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            return new GenericResponse<List<Book>>
            {
                Success = true,
                Data = members,
            };
        }
    }
}
