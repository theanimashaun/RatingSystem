# Rating System

In order to calculate the top rated book in the collection of books (and respective ratings), we have to consider the amount of ratings submitted for each book, this is referred to as the weight.

A mathematical formula to rank the books, taking respective weights into consideration, is called Bayesian Rating.

We calculate a rating of an item based on the “believability” of the votes.

The formula below is  used

`ranking = ( (avg_num_votes * avg_rating) + (this_num_votes * this_rating) ) / (avg_num_votes + this_num_votes);`

Ordering the list of books by the calculated ranking, descendingly, puts the winner at the top of the list.
