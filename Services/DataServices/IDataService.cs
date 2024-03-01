using Domains.ViewModels;

namespace Services.DataServices {
    public interface IDataService<TModel> {
        TModel GetAll(RequestModel request);
    }
}
