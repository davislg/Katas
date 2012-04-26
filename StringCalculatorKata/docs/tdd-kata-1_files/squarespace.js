var disqus_url = Squarespace.Constants.OBJECT_PERMALINK;
(function() {
	// Output styles
	document.write('<style type="text/css">#postform, #comments .caption, #comments .text, #comments .comment-wrapper { display:none; }</style>');

	// Initialize comments container
	var cEl = document.getElementById('comments');
	if(cEl) {
		cEl.id = 'disqus_thread';
		cEl.innerHTML = '';
	}

	// Comment count
	var links = document.getElementsByTagName('a');
	var query = '?';
	for(var i = 0; i < links.length; i++) {
	  if (links[i].href.indexOf('#comments') >= 0) {
		links[i].href = links[i].href.substring(0, links[i].href.length-9) + "#disqus_thread";
		query += 'url' + i + '=' + encodeURIComponent(links[i].href) + '&';
	  }
	}
	document.write('<script type="text/javascript" src="http://disqus.com/forums/' + disqus_forum_url + '/get_num_replies.js' + query + '"></' + 'script>');
})();
