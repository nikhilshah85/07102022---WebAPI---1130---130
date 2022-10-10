namespace productsWebAPI.Model
{
    public class Products
    {

        #region Properties
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }

        #endregion

        #region Data

        static List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new Products(){ pId=102, pName="Maggie", pCategory="Fast-Food", pIsInStock=true, pPrice=50},
            new Products(){ pId=103, pName="IPhone", pCategory="Electronic", pIsInStock=false, pPrice=50},
            new Products(){ pId=104, pName="Flying Machine", pCategory="Jeans", pIsInStock=true, pPrice=50},
            new Products(){ pId=105, pName="Green-tea", pCategory="Health-Drink", pIsInStock=false, pPrice=50},
        };


        #endregion

        #region Get Methods
        public List<Products> GetALlProducts()
        {
            return pList;
        }

        public Products GetProductById(int id)
        {
            var p = pList.Find(pr => pr.pId == id);
            if (p != null)
            {
                return p;
            }
            throw new Exception("Product Not Found in System");
        }
        #endregion

        #region Add, Update and Delete
        public string AddProduct(Products newProduct)
        {
            //perform some validation

            pList.Add(newProduct);
            return "Product Added Successfully";
        }

        public string DeleteProduct(int pid)
        {
            var p = pList.Find(pr => pr.pId == pid);
            if (p != null)
            {
                pList.Remove(p);
                return "Product Deleted Successfully";
            }
            throw new Exception("Product Not found - and thus cannot be deleted");
        }

        public string UpdateProduct(Products product)
        {
            var p = pList.Find(pr => pr.pId == product.pId);
            if (p != null)
            {
                p.pName = product.pName;
                p.pCategory = product.pCategory;
                p.pPrice = product.pPrice;
                p.pIsInStock = product.pIsInStock;
                return "Product updated successfully";
            }
            throw new Exception("Product Not found - and thus cannot be Edited");
        }
        #endregion
    }
}











