using Microsoft.EntityFrameworkCore;
using Moq;

namespace Infrastructure.Test.Helper
{
    public static class MockDbSetHelper<T> where T : class
    {
        public static Mock<DbSet<T>> CreateMockDbSet(List<T> sourceList)
        {
            var queryable = sourceList.AsQueryable();
            var dbSetMock = new Mock<DbSet<T>>();

            dbSetMock.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
            dbSetMock.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
            dbSetMock.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            dbSetMock.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(queryable.GetEnumerator());

            return dbSetMock;
        }
    }
}
