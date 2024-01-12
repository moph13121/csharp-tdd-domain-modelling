#Domain Models In Here
| Classes         | Methods                                     | Scenario               | Outputs					   |
|-----------------|---------------------------------------------|------------------------|-----------------------------|
| `CohortSearch`  | `search(List<string> cohorts, String name)` | If name is in list     | list of matching cohorts    |
|                 |                                             | If name is not in list | empty list				   |
| `TotalPrice`    | `sum(List<string, double, int> cart)`		| If cart has items      | total value of items		   |
|                 |                                             | If cart has no items   | 0        				   |
| `Checkout`	  | `print(List<string, double, int> cart)`		| If cart has items		 | print receipt			   |
|				  |												| If cart has no items	 | don't print receipt		   |