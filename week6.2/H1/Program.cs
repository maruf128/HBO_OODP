DocumentCollection collection = new DocumentCollection();
TextDocument groceryList = new TextDocument("Grocery list", "2 milk; 6 eggs");
collection.AddDocument(groceryList);

Document foundDocument = collection.FindDocument("Grocery list");
if (foundDocument != null)
{
    foundDocument.Accept(new DocumentVisitor());
}
