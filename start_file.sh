#!/bin/bash

# Перевірка, чи передано повідомлення коміту
if [ -z "$1" ]; then
  echo "Будь ласка, введіть повідомлення коміту після /start_file"
  exit 1
fi

COMMIT_MESSAGE="$*"

# Виконання Git команд
git add .
git commit -m "$COMMIT_MESSAGE"
git push
