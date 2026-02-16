namespace OMGYavuz
{
    public class Model : IModel
    {
        private IView view;
        private IController controller;

        public Model()
        {
        }

        public void setView(IView view)
        {
            this.view = view;
        }

        public void setController(IController controller)
        {
            this.controller = controller;
        }
    }
}
