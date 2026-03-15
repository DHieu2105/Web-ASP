using WebApp1.Models;
namespace WebApp1.Repository
{
    public class LoaiSpRepository : ILoaiSpRepository
    {
        private readonly  QlbanVaLiContext _context;

        public LoaiSpRepository(QlbanVaLiContext context)
        {
            _context = context;
        }
        public TLoaiSp Add(TLoaiSp loaiSp)
        {
            _context.TLoaiSps.Add(loaiSp);
            _context.SaveChanges();
            return loaiSp;
        }

        public TLoaiSp Delete(string maloaiSp)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TLoaiSp> GetAllLoaiSps()
        {
            return _context.TLoaiSps.ToList();
        }

        public TLoaiSp GetLoaiSp(string maloaiSp)
        {
            return _context.TLoaiSps.Find(maloaiSp);
        }

        public TLoaiSp Update(TLoaiSp loaiSp)
        {
            _context.TLoaiSps.Update(loaiSp);
            _context.SaveChanges();
            return loaiSp;
        }
    }
}
