FROM python:3.14-slim

ENV PYTHONUNBUFFERED=1

WORKDIR /app

COPY requirements.txt .
RUN pip install --no-cache-dir -r requirements.txt

COPY immich_sync/ immich_sync/

CMD ["python", "-m", "immich_sync.main", "schedule"]
