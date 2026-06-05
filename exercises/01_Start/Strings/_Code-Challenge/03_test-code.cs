// This is how your code will be called.
// You can edit this code to try different testing cases.
object[] items = {1, 2, "Hello!", "World", 'X', true, 2.0, ".NET", 'A', "😎", 'ť'};
int total = 0;
// string CountType = "System.String";
// string CountType = "System.Char";
// string CountType = "System.Int32";
// string CountType = "System.Boolean";
string CountType = "System.Double";
foreach (object item in items) {
    if (Answer.CountTheType(item, CountType)) {
		total++;
	}
}