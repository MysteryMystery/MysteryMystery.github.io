$(document).ready(function(){
	$(".showcase-section").hover(
		function(){
			$(this).addClass("shadow-lg");
			$(this).animate({"marginTop": "-=0.2em"});
		}, 
		function(){
			$(this).removeClass("shadow-lg");
			$(this).animate({"marginTop": "+=0.2em"});
		}
	);
});