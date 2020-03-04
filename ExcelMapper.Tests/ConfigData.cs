using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelMapper.Tests
{
    public class ConfigData
    {
        public string size { get; set; }
        public string color { get; set; }
        public string itemNumber { get; set; }
        public string decorationTechnologyCode { get; set; }
        public string locationCode { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public string ItemNumber
        {
            get
            {
                return itemNumber.Trim();
            }
            set
            {
                itemNumber = value;
            }
        }
        public string Size
        {
            get
            {
                return size.Trim();
            }
            set
            {
                size = value;
            }
        }
        public string Color
        {
            get
            {
                return color.Trim();
            }
            set
            {
                color = value;
            }
        }
        public string DecorationTechnologyCode
        {
            get
            {
                return decorationTechnologyCode.Trim();
            }
            set
            {
                decorationTechnologyCode = value;
            }
        }
        public string LocationCode
        {
            get
            {
                return locationCode.Trim();
            }
            set
            {
                locationCode = value;
            }
        }
        public string fulfillerName { get; set; }
        public string FulfillerName { get { return fulfillerName; } set { fulfillerName = value; } }
        public string marketplaceCode { get; set; }
        public string MarketplaceCode { get { return marketplaceCode; } set { marketplaceCode = value; } }
        public string marketplaceProductBarcode { get; set; }
        public string MarketplaceProductBarcode { get { return marketplaceProductBarcode; } set { marketplaceProductBarcode = value; } }
        public string partnerCode { get; set; }
        public string PartnerCode { get { return partnerCode; } set { partnerCode = value; } }
        public bool? IsActive { get; set; }
        public int MinimumQuantity { get; set; }
        public int MaximumQuantity { get; set; }
        public int QuantityIncrement { get; set; }
        public decimal surfaceWidthInMm { get; set; }
        public decimal SurfaceWidthInMm { get { return surfaceWidthInMm; } set { surfaceWidthInMm = value; } }
        public decimal surfaceHeightInMm { get; set; }
        public decimal SurfaceHeightInMm { get { return surfaceHeightInMm; } set { surfaceHeightInMm = value; } }
        public string ScenePrefix { get; set; }

        public string theme { get; set; }
        public string Theme { get { return theme; } set { theme = value; } }
        public string design_rule { get; set; }
        public int? minSize { get; set; }
        public int? MinSize { get { return minSize; } set { minSize = value; } }
        public int? maxSize { get; set; }
        public int? MaxSize { get { return maxSize; } set { maxSize = value; } }
        public double? itemPrice { get; set; }
        public double? ItemPrice { get { return itemPrice; } set { itemPrice = value; } }
        public double? decorationPrice { get; set; }
        public double? DecorationPrice { get { return decorationPrice; } set { decorationPrice = value; } }
        public double? totalPrice { get; set; }
        public double? TotalPrice { get { return totalPrice; } set { totalPrice = value; } }

        public string categoryname { get; set; }

        #region EmbroideryRecipe
        public string Backing { get; set; }
        public int? NumberOfBackings { get; set; }
        // https://embroideryrecipe.miproducts.cimpress.io/v1/color/{ColorName}
        public string BackingColorName { get; set; }
        public string HoopingFrame { get; set; }
        public string FrameSize { get; set; }
        public string FrameSetting { get; set; }
        public int? Rpm { get; set; }
        public int? FrontStabilizerNumber { get; set; }
        //Must be degree measurement between 0 and 360
        public int? RotationOnPress { get; set; }
        #endregion

        #region PrintRecipe
        public string Plate { get; set; }
        public string PlateOrientation { get; set; }
        public int? DegreesCelcius { get; set; }
        public int? Duration { get; set; }
        public double? PressureBar { get; set; }
        public string PrintPerfectConfiguration { get; set; }
        #endregion

        public string categories { get; set; }
        public string base_image { get; set; }
        public string small_image { get; set; }
        public string thumbnail_image { get; set; }
        public string materialCode { get; set; }
        public string MaterialCode { get { return materialCode; } set { materialCode = value; } }
        public string rolandTechnology { get; set; }
        public string RolandTechnology { get { return rolandTechnology; } set { rolandTechnology = value; } }
        public string rolandMaterial { get; set; }
        public string RolandMaterial { get { return rolandMaterial; } set { rolandMaterial = value; } }
        public string surfaceType { get; set; }
        public string SurfaceType { get { return surfaceType; } set { surfaceType = value; } }
        public double? weightWithPKG { get; set; }
        public double? WeightWithPKG { get { return weightWithPKG; } set { weightWithPKG = value; } }
        public int? ProductSequence { get; set; }
        public string TrimPadding { get; set; }

        public bool? multiLocation { get; set; }

        public bool? mixTech { get; set; }

        public bool? needMirroring { get; set; }

        public bool ready { get; set; }

        public double GetPrice()
        {
            if (TotalPrice.HasValue)
            {
                return TotalPrice.Value;
            }
            else
            {
                var itemPrice = ItemPrice.HasValue ? ItemPrice.Value : 0.00;
                var decorationPrice = DecorationPrice.HasValue ? DecorationPrice.Value : 0.00;
                return itemPrice + decorationPrice;
            }
        }

        public Dictionary<string, string> metadata { get; set; }
        public string sceneFolder { get; set; }
        public bool? SizeEnable { get; set; }
        public string ManufacturerDataFormat { get; set; }
        public string pageName { get; set; }
        public int? locationX { get; set; }
        public int? locationY { get; set; }
        public bool? needTrun { get; set; }
    }
}
