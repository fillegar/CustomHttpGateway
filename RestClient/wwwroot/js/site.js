// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

	function callAPI(path) {
		let request = new XMLHttpRequest();
	request.open("GET", "https://localhost:5001/" + path);
	request.send();
		request.onload = () => {
			if (request.status === 200) {
		alert(request.response);
			} else {
		alert(`Error: ${request.status} ${request.statusText}`);
			}
		}
	}

