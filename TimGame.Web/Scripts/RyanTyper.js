﻿var paragraphs = $('p.phrase');
var button = $('#continueText');
var activeIndex = 0;

function getCharacterCount(el) {
  return el.text().trim().length;
}


function setNextActive() {
  button.hide();
  paragraphs.removeClass('active');
  
  var animated = paragraphs.eq(activeIndex);
  var  characters = getCharacterCount(animated);
  
  animated.toggleClass('active')
    .animate({
      width: `${characters * 0.623}em`,
    }, {
      duration: 70 * characters,
      easing: 'linear',
      complete() {
        if (activeIndex !== paragraphs.length) {
          button.show();          
        }
      }
    });
}

button.on('click', function() {
  setNextActive();
  activeIndex++;
});
