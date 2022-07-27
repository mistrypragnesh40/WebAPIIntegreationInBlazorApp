using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIIntegreationInBlazorApp.Models;

namespace WebAPIIntegreationInBlazorApp.Services
{
    public interface IStudentService
    {
        Task<List<StudentResponseModel>> GetAllStudentList();
        Task<MainResponseModel> AddStudent(AddUpdateStudentRequest studentRequest);
        Task<MainResponseModel> UpdateStudent(AddUpdateStudentRequest studentRequest);
        Task<MainResponseModel> DeleteStudent(AddUpdateStudentRequest studentRequest);
        Task<StudentResponseModel> GetStudentDetailByStudentID(int studentID);


    }
}
