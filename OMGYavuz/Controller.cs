namespace OMGYavuz
{
    public class Controller : IController
    {
        private IModel model;
        private IView view;

        public Controller()
        {
        }

        public void setModel(IModel model)
        {
            this.model = model;
        }

        public void setView(IView view)
        {
            this.view = view;
        }

        public void gGTBestimmen(int zahl1, int zahl2)
        {
            while (zahl2 != 0)
            {
                int rest = zahl1 % zahl2;
                zahl1 = zahl2;
                zahl2 = rest;
            }

            view.anzeigen(zahl1);
            //test
        }
    }
}
