using Demography.Infrastructure.Domain;
using Demography.Infrastructure.Enums;
using Demography.Infrastructure.Extensions;
using Demography.Infrastructure.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demography.WinForms.Controllers
{
    public class ListController
    {
        private IUnitOfWork _unitOfWork;   
        public ListController()
        {
            _unitOfWork = Program.GetUnitOfWork();
        }
        public void InitDropDownListEnum<T>(ComboBox dropDownList, bool withEmpty = false) where T : Enum
        {
            dropDownList.DropDownStyle = ComboBoxStyle.DropDownList;
            var dataSource = new[] { new { Name = "Выберите", Value = (int?)null } }.ToList();
            if (!withEmpty)
            {
                dataSource.Clear();
            }
            dataSource.AddRange(Enum.GetValues(typeof(T)).Cast<T>().Select(p => new { Name = p.GetDisplayName(), Value = (int?)p.GetIntValue() }).ToList());

            dropDownList.DisplayMember = "Name";
            dropDownList.ValueMember = "Value";
            dropDownList.DataSource = dataSource;
        }

        public void DropDownListClinics(ComboBox dropDownList, bool withEmpty = false)
        {
            dropDownList.DropDownStyle = ComboBoxStyle.DropDownList;
            var dataSource = new[] { new { Name = "Выберите", Value = (int?)null } }.ToList();
            if (!withEmpty)
            {
                dataSource.Clear();
            }
            dataSource.AddRange(_unitOfWork.Clinics.All().Select(x=> new {Name= x.Name,Value = (int?)x.Id}).ToList());

            dropDownList.DisplayMember = "Name";
            dropDownList.ValueMember = "Value";
            dropDownList.DataSource = dataSource;
        }



        public void DropDownListRoles( ComboBox dropDownList, bool withEmpty = false)
        {
            dropDownList.DropDownStyle = ComboBoxStyle.DropDownList;
            var dataSource = new[] { new { Name = "Выберите", Value = (int?)null } }.ToList();
            if (!withEmpty)
            {
                dataSource.Clear();
            }
            dataSource.AddRange(_unitOfWork.Roles.All().Select(x => new { Name = x.Name, Value = (int?)x.Id }).ToList());

            dropDownList.DisplayMember = "Name";
            dropDownList.ValueMember = "Value";
            dropDownList.DataSource = dataSource;
        }
        public void DropDownListEducation(ComboBox dropDownList, bool withEmpty = false)
        {
            dropDownList.DropDownStyle = ComboBoxStyle.DropDownList;
            var dataSource = new[] { new { Name = "Выберите", Value = (int?)null } }.ToList();
            if (!withEmpty)
            {
                dataSource.Clear();
            }
            dataSource.AddRange(_unitOfWork.Educations.All().Select(x => new { Name = x.Name, Value = (int?)x.Id }).ToList());

            dropDownList.DisplayMember = "Name";
            dropDownList.ValueMember = "Value";
            dropDownList.DataSource = dataSource;
        }
        public void DropDownListEmployment(ComboBox dropDownList, bool withEmpty = false)
        {
            dropDownList.DropDownStyle = ComboBoxStyle.DropDownList;
            var dataSource = new[] { new { Name = "Выберите", Value = (int?)null } }.ToList();
            if (!withEmpty)
            {
                dataSource.Clear();
            }
            dataSource.AddRange(_unitOfWork.Employments.All().Select(x => new { Name = x.Name, Value = (int?)x.Id }).ToList());

            dropDownList.DisplayMember = "Name";
            dropDownList.ValueMember = "Value";
            dropDownList.DataSource = dataSource;
        }
        public void DropDownListUsers(ComboBox dropDownList, bool withEmpty = false)
        {
            dropDownList.DropDownStyle = ComboBoxStyle.DropDownList;
            var dataSource = new[] { new { Name = "Выберите", Value = (int?)null } }.ToList();
            if (!withEmpty)
            {
                dataSource.Clear();
            }
            dataSource.AddRange(_unitOfWork.Users.All().Select(x => new { Name = x.LastName+" "+ x.FirstName+" "+x.MiddleName, Value = (int?)x.Id }).ToList());

            dropDownList.DisplayMember = "Name";
            dropDownList.ValueMember = "Value";
            dropDownList.DataSource = dataSource;
        }
        public void DropDownListProfileTypeForUser(ComboBox dropDownList, bool withEmpty = false)
        {
            dropDownList.DropDownStyle = ComboBoxStyle.DropDownList;

            var dataSource = new[] { new { Name = "Выберите", Value = (int?)null } }.ToList();
            if (!withEmpty)
            {
                dataSource.Clear();
            }
            dataSource.AddRange(CurrentUser.RolesWithoutRestrictionProfile.Where(x => x.ProfileTypeId != null).Select(x => new { Name=((ProfileTypeApp)x.ProfileTypeId.Value).GetDisplayName(),Value = x.ProfileTypeId }).Distinct().ToList());
            
            dropDownList.DisplayMember = "Name";
            dropDownList.ValueMember = "Value";
            dropDownList.DataSource = dataSource;
        }

        public void DropDownListPositions( ComboBox dropDownList, bool withEmpty = false)
        {
            dropDownList.DropDownStyle = ComboBoxStyle.DropDownList;

            var dataSource = new[] { new { Name = "Выберите", Value = (string)null } }.ToList();
            if (!withEmpty)
            {
                dataSource.Clear();
            }
            dataSource.AddRange(_unitOfWork.PositionFed00004s.All().OrderBy(x=>x.Name).Select(x => new { Name = x.Name, Value = x.Id.ToString() +"|" +x.Version.ToString() }).ToList());

            dropDownList.DisplayMember = "Name";
            dropDownList.ValueMember = "Value";
            dropDownList.DataSource = dataSource;
        }

        public void DropDownListPositionsForUserId(ComboBox dropDownList, int? userId,bool withEmpty = false)
        {
            dropDownList.DropDownStyle = ComboBoxStyle.DropDownList;
            var userRoles = _unitOfWork.UserClinics.Filter(x => x.UserId == userId).Include(x=>x.Position).Select(x =>new { Name = x.Position.Name, Value = x.PostCode + "|" + x.PostVersion }).ToList();
            var dataSource = new[] { new { Name = "Выберите", Value = (string)null } }.ToList();
            if (!withEmpty)
            {
                dataSource.Clear();
            }
            dataSource.AddRange(userRoles);

            dropDownList.DisplayMember = "Name";
            dropDownList.ValueMember = "Value";
            dropDownList.DataSource = dataSource;
        }

        public void DropDownListDocType(ComboBox dropDownList, bool withEmpty = false)
        {
            dropDownList.DropDownStyle = ComboBoxStyle.DropDownList;

            var dataSource = new[] { new { Name = "Выберите", Value = (int?)null } }.ToList();
            if (!withEmpty)
            {
                dataSource.Clear();
            }
            dataSource.AddRange(_unitOfWork.PeopleDocTypes.All().OrderBy(x => x.Name).Select(x => new { Name = x.Name, Value = (int?)x.Id }).ToList());

            dropDownList.DisplayMember = "Name";
            dropDownList.ValueMember = "Value";
            dropDownList.DataSource = dataSource;
        }

        internal void InitDropDownListEnum<T>(object statusComboBox)
        {
            throw new NotImplementedException();
        }
    }
}
