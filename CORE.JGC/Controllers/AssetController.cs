using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CORE.JGC.Models;

namespace CORE.JGC.Controllers
{
    public class AssetController : Controller
    {
        DCAssetDataContext dc = null;
        // GET: Asset
        private Ms_Asset[] GridAsset()
        {
            dc = new DCAssetDataContext();
            List<Ms_Asset> msasset = new List<Ms_Asset>();
            try
            {
                var query = dc.MsAsset_View("", "G");
                foreach (var res in query)
                {
                    Ms_Asset asset = new Ms_Asset();
                    asset.Photo = res.AssetPhoto;
                    asset.AssetCode = res.AssetTagID;
                    asset.AssetName = res.AssetName;
                    asset.AssetBrandCode = res.AssetBrand;
                    asset.PurchaseDate = res.PurchaseDate;
                    asset.PurchasePrice = res.PurchasePrice;
                    asset.bStatus = res.NamaStatus;
                    msasset.Add(asset);
                }
            }
            catch
            {
                msasset = null;
            }
            return msasset.ToArray();
        }
        public ActionResult Index()
        {
            Ms_Asset[] msasset = null;
            msasset = GridAsset();
            return View(msasset);
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Createmaintenance()
        {
            return View();
        }

        public ActionResult Checkout()
        {
            return View();
        }

        public ActionResult Checkin()
        {
            return View();
        }

        public ActionResult Lease()
        {
            return View();
        }

        public ActionResult Leasereturn()
        {
            return View();
        }
    
        public ActionResult Dispose()
        {
            return View();
        }

        public ActionResult Move()
        {
            return View();
        }

        public ActionResult Assetpastdue()
        {
            return View();
        }

        public ActionResult Maintenancedue()
        {
            return View();
        }

        public ActionResult Warrantiesexpiring()
        {
            return View();
        }
    }
}