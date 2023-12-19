using POSDesignDemo.Models;
using POSDesignDemo.Test;
using POSDesignDemo.View;
using POSDesignDemo.View.SubMenuView;
/*using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;*/

namespace POSDesignDemo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var fromProduct = new MainContainerView();
            fromProduct.StartPosition = FormStartPosition.CenterScreen;
            fromProduct.ShowDialog();

        }
    }
}