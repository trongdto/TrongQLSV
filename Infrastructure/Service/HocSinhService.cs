using Infrastructure.Entities;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public interface ISinhVienService
    {
        IQueryable<SinhVien> GetTatCaHocSinh();
        SinhVien GetSinhVien(int id);
        void InsertHocSinh(SinhVien sinhVien);
        void UpdateHocSinh(SinhVien  sinhVien);
        void DeleteHocSinh(SinhVien sinhVien);
    }

    public class HocSinhService : ISinhVienService
    {
        private ISinhVienRepository sinhVienRepository;

        public HocSinhService(ISinhVienRepository sinhVienRepository)
        {
            this.sinhVienRepository = sinhVienRepository;
        }


        public SinhVien GetSinhVien(int id)
        {
            return sinhVienRepository.GetById(id);
        }

        public void InsertHocSinh(SinhVien sinhVien)
        {
            sinhVienRepository.Insert(sinhVien);
        }

        public void UpdateHocSinh(SinhVien sinhVien)
        {
            sinhVienRepository.Update(sinhVien);
        }

        public void DeleteHocSinh(SinhVien hocSinh)
        {
            sinhVienRepository.Delete(hocSinh);
        }

        public IQueryable<SinhVien> GetTatCaHocSinh()
        {
            return sinhVienRepository.GetAll();
        }
    }
}
