
//Search results page

// searches omdbapi using the searchterm entered and creates json file. Takes objects from file and adds to new html code to display search results
let searchbutton = document.getElementById('searchbutton').addEventListener('click', async function () {
    let searchterm = document.getElementById("searchterm").value;
    console.log(searchterm)
    let searchresults
    let url = 'https://www.omdbapi.com/?apikey=7e6fbf1&s=' + searchterm;
    let result = await fetch(url);
    searchresults = await result.json();
    console.log(searchresults)

    let search = searchresults.Search;
    let container = document.getElementById("searchcontainer");

    //clears previous search results
    function clearcontent() {
        document.getElementById("searchcontainer").innerHTML = "";
    }
    clearcontent()

    //loops through all search results and sets html
    for (let i = 0; i < search.length; i++) {

        let poster = document.createElement("img");
        let title = document.createElement("h3");
        let year = document.createElement("p");
        let buttonviewdetails = document.createElement("button")
        let likebutton = document.createElement("button")
        let dislikebutton = document.createElement("button")
        var div = document.createElement("div");

        poster.src = search[i].Poster;
        title.textContent = search[i].Title;
        year.textContent = search[i].Year;
        
        poster.setAttribute("class", "icon")
        title.setAttribute("class", "content")
        year.setAttribute("class", "content")
        buttonviewdetails.setAttribute("class", "view")
        likebutton.setAttribute("class", "likebutton")
        dislikebutton.setAttribute("class", "dislikebutton")
        div.setAttribute("class", "movieresults")
        container.setAttribute("class", "container")

        likebutton.appendChild(document.createTextNode('Like'));
        dislikebutton.appendChild(document.createTextNode('Dislike'));
        div.appendChild(poster);
        div.appendChild(title);
        div.appendChild(year);
        div.appendChild(likebutton);
        div.appendChild(dislikebutton);
        div.appendChild(buttonviewdetails);
        container.appendChild(div);

        // displays selected movie
        buttonviewdetails.addEventListener("click", function () {
            
            window.location = "MoviePage/Index/" + search[i].imdbID
        });

        // sends like/dislike votes to CMDb API
        const baseendpoint = 'https://grupp9.dsvkurs.miun.se/api/';

        likebutton.addEventListener("click", function () {
            fetch(baseendpoint + search[i].imdbID + '/like')
                .then(response => response.json())
                .then(data => {
                    console.log(data)
                });
            onClick = this.disabled = true;
            onClick = dislikebutton.disabled = true;
        });

        dislikebutton.addEventListener("click", function () {
            fetch(baseendpoint + search[i].imdbID + '/dislike')
                .then(response => response.json())
                .then(data => {
                    console.log(data)
                });
            onClick = this.disabled = true;
            onClick = likebutton.disabled = true;
        });
    }
    console.log(container)
});




