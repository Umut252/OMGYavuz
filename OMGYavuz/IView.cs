namespace OMGYavuz
{
    public interface IView
    {
        void setModel(IModel model);
        void setController(IController controller);
        void anzeigen(int ggt);
    }
}
