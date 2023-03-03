// voting on MoviePage

const baseendpoint = 'https://grupp9.dsvkurs.miun.se/api/';
let imdbid = document.getElementById("votelike").value
let likebutton = document.getElementById("votelike")
let dislikebutton = document.getElementById("votedislike")

// sends vote to CMDb API and updates number of likes/dislikes and also disables buttons to prevent further voting
likebutton.addEventListener("click", function () {
    fetch(baseendpoint + imdbid + '/like')
        .then(response => response.json())
        .then(data => {
            document.getElementById('nrOfLikes').innerHTML = data['numberOfLikes']
            console.log(data)
        });
    onClick = this.disabled = true;
    onClick = dislikebutton.disabled = true;
});

dislikebutton.addEventListener("click", function () {
    fetch(baseendpoint + imdbid + '/dislike')
        .then(response => response.json())
        .then(data => {
            document.getElementById('nrOfDislikes').innerHTML = data['numberOfDislikes']
            console.log(data)
        });
    onClick = this.disabled = true;
    onClick = likebutton.disabled = true;
});