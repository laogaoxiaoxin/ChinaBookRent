﻿using System.Collections.Generic;

namespace ChinaBookRentDataClass
{
    //豆瓣网数据------------------------------------------------------------------------------------------------------------------------------------------------------------------
    class BookRating
    {
        public int max;
        public int numRaters;
        public string average;
        public int min;
    }

    class BookImage
    {
        public string small;
        public string medium;
        public string large;
    }
    class BookTags
    {
        public int count;
        public string name;
        public string title;
    }
    class BookSeries
    {
        public string id;
        public string title;
    }
    class BookInfo
    {
        public BookRating rating;
        public string subtitle;
        public string[] author;
        public BookTags[] tags;
        public string origin_title;
        public string image;
        public string[] translator;
        public string catalog;
        public string pages;
        public string alt;
        public string id;
        public string binding;
        public string isbn10;
        public string isbn13;
        public string url;
        public string alt_title;
        public string author_intro;
        public string pubdate;
        public BookImage images;
        public string publisher;
        public string title;
        public string summary;
        public string price;
        public BookSeries series;
        public string ebook_url;
        public string ebook_price;
    }

    //当当阅读数据------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public class CategoriesItem
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class SearchMediaPaperListItem
    {
        public string author { get; set; }
        public int carded { get; set; }
        public string description { get; set; }
        public int freeBook { get; set; }
        public string id { get; set; }
        public int isFull { get; set; }
        public int isSupportFullBuy { get; set; }
        public double lowestPrice { get; set; }
        public string medType { get; set; }
        public string mediaPic { get; set; }
        public double originalPrice { get; set; }
        public string paperBookId { get; set; }
        public int priceUnit { get; set; }
        public string publishDate { get; set; }
        public string publisher { get; set; }
        public double salePrice { get; set; }
        public int saleWeek { get; set; }
        public int stored { get; set; }
        public string title { get; set; }
        public string totalReviewCount { get; set; }
    }

    public class Data
    {
        public System.Collections.Generic.List<CategoriesItem> categories { get; set; }
        public string currentDate { get; set; }
        public string keyword { get; set; }
        public System.Collections.Generic.List<SearchMediaPaperListItem> searchMediaPaperList { get; set; }
        public string systemDate { get; set; }
        public System.Collections.Generic.List<string> tipsCategories { get; set; }
        public int totalCount { get; set; }
    }

    public class Status
    {
        public int code { get; set; }
    }

    public class Root
    {
        public Data data { get; set; }
        public Status status { get; set; }
        public long systemDate { get; set; }
    }
}

namespace DangDangNetBean
{
    [System.Serializable]
    public class Page
    {
        public Page() { }
        /// <summary>
        /// 
        /// </summary>
        public string total { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pagecount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pageindex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pagesize { get; set; }
    }
    [System.Serializable]
    public class CategoriesItem
    {
        public CategoriesItem() { }
        /// <summary>
        /// 
        /// </summary>
        public string CatID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Priority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Count { get; set; }
        /// <summary>
        /// 童书
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CatPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ID { get; set; }
    }
    [System.Serializable]
    public class Current_cat
    {
        public Current_cat() { }
        /// <summary>
        /// 图书
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CatPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ClassCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CatID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string guan_id { get; set; }
        /// <summary>
        /// 图书
        /// </summary>
        public string ClassName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ID { get; set; }
    }
    [System.Serializable]
    public class Stars
    {
        public Stars() { }
        /// <summary>
        /// 
        /// </summary>
        public int full_star { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_half_star { get; set; }
    }
    [System.Serializable]
    public class Product_tagsItem
    {
        public Product_tagsItem() { }
        /// <summary>
        /// 赠品
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int type { get; set; }
    }
    [System.Serializable]
    public class ProductsItem
    {
        public ProductsItem() { }
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int stock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string total_review_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int score { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Stars stars { get; set; }
        /// <summary>
        /// 猎豹绝唱 沈石溪 等 著
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 【好评返5元店铺礼券】
        /// </summary>
        public string subname { get; set; }
        /// <summary>
        /// 沈石溪 等 著
        /// </summary>
        public string authorname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string promotype { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int promotion_filt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string shop_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dd_sale_price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string exclusive_price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string real_dd_sale_price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string promo_sale_price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string activity_price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string readable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int book_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int is_ebook { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_has_ebook { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ebook_product_id { get; set; }
        /// <summary>
        /// 文轩网旗舰店
        /// </summary>
        public string shop_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ebook_price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ebook_dd_price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cat_paths { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string high_common_rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_publication { get; set; }
        /// <summary>
        /// 安徽少年儿童出版社
        /// </summary>
        public string publisher { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string publish_date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string original_price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_overseas { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int activity_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> word_highlight_keys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string product_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pre_sale { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string presale_start_date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string presale_end_date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string presale_rank_num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int add_cart_button_enabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string label_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string label_type_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_catalog_product { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_yb_product { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string discount_icon_title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string exclusive_spare_price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int has_ebook { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_wished { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int show_dangdangsale { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Product_tagsItem> product_tags { get; set; }
    }
    [System.Serializable]
    public class Direct_category_pathItem
    {
        public Direct_category_pathItem() { }
        /// <summary>
        /// 图书
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string path { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
    }

    [System.Serializable]
    public class Root
    {
        public Root() { }
        /// <summary>
        /// 
        /// </summary>
        public List<string> ShopInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Page page { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mix_reco { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string webtemplate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> posters { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<CategoriesItem> categories { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string brands { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Current_cat current_cat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> parrent_cat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ProductsItem> products { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int show_search_banner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> shop_banner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int support_shop_tmp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> sort_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Direct_category_pathItem> direct_category_path { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string showcase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_filter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string search_relate_keywords { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int add_cart_enabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> promotions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> screening { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string true_sort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int no_ad { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int less_result_enabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Banner> banner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string row_num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string share_url { get; set; }
    }

    public class Banner
    {
        public Banner() { }
        public string link;
        public string img;
    }

}